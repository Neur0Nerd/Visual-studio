(*------------- Palier 0 -------------*)


(*0.1*)

let gen_list n =
if n < 0 then invalid_arg "n<0"
else let rec gen_list n = match n with
  |0 -> []
  |_ -> 0 :: gen_list(n-1)
     in
gen_list n ;;

gen_list 10;;

(*0.2*)

let gen_rand_list n =
if n < 0 then invalid_arg "n<0"
else let rec gen_rand_list n = match n with
  |0 -> []
  |_ -> Random.int(2) :: gen_rand_list(n-1)
     in
gen_rand_list n ;;

gen_rand_list 10;;

(*0.3*)

let gen_board n =
if n < 0 then failwith "n<0"
else  let rec gen = function
  |0 -> []
  |a -> gen_list n ::gen (a-1)
     in
gen n;;

gen_board 4 ;;


let gen_rand_board n =
if n < 0 then invalid_arg "n<0"
else let rec gen_rand_board n = match n with
  |0 -> []
  |_ -> [Random.int(2);Random.int(2);Random.int(2)]::gen_rand_board(n-1)
     in
gen_rand_board n;;

gen_rand_board 3;;


(*------------- Palier 1 -------------*)

(*1.1*)

let cell_count list =
  let rec compte list acc = match list with
  |[] -> acc
  |e::list when e>0 -> compte list (acc+1)
  |e::list when e=0 -> compte list (acc)
  |_::_ -> failwith "no live cells"
 in
compte list 0 ;;

cell_count [0;1;0;1;0;0;0;0;1;1];;

(*1.2*)

let remaining list =
  let rec compte list acc = match list with
  |[] -> acc
  |e::list -> compte list (acc + cell_count e)
 in
compte list 0 ;;

remaining [[0;1;0];[1;1;0];[0;0;1]];;



(*------------- Palier 2 -------------*)

(*2.1*)

#load "graphics.cma";;
open Graphics;;
open_graph "1000*1000" ;;

let draw_square (x,y) size =
draw_rect x y size size ;;

draw_square (50,50) 50;;


(*2.2*)

let draw_fill_square (x,y) size color=
open_graph "1000*1000";
set_color color;
fill_rect x y size size;;

draw_fill_square (50,50) 50 blue;;


(*2.3*)

let draw_cell (x,y) size cell = match cell with
  |0 -> draw_fill_square (x,y) size white
  |1 -> draw_fill_square (x,y) size black
  |_ -> failwith "Not a cell";;

draw_cell (50,50) 50 1;;


(*2.4*)

let draw_board board size = 
  let rec iter_hor x = function
    |[] -> ()
    |e::l -> iter_ver x 0 e; iter_hor (x+size) l
  and iter_ver x y = function
    | [] -> ()
    | e::l when e=1 -> draw_fill_square (x,y) size red ; iter_ver x (y+size) l
    | e::l when e=0 -> draw_fill_square (x,y) size blue ; iter_ver x (y+size) l
    | _::_ -> failwith "empty lists or not binary data"
  in
iter_hor 0 board ;;


draw_board [[0;0;1];[1;0;1]] 60;;



(*------------- Palier 3 -------------*)


(*3.1*)

(*let get_cell (x,y) board =
if board = [] then failwith "empty list"
else List.nth (List.nth board (x-1)) (y-1);;

get_cell (2,1) ([[0;1;2];[3;4;5];[6;7;8]]);;

get_cell (2,1) ([]);;*)

let get_cell (x,y) board =
  let rec get_line l i = match l with
    |[] -> failwith "Empty line"
    |e::l when i < x -> get_line l (i + 1)
    |e::l when i = x -> get_column e 1
and
  get_column l i = match l with
    |[] -> failwith "Empty line"
    |e::l when i < y -> get_column l (i + 1)
    |e::l when i = y -> e
in get_line board 1 ;;


(*3.2*)

let replace_cell n (x,y) board =
  let rec replace_liste y liste = match liste with
    |[] -> failwith "y trop grand"
    |e::liste when y=1 -> n::liste
    |e::liste -> e::(replace_liste (y-1) liste)
  in
  let rec replace_element (x,y) board = match board with
    |[] -> failwith "x trop grand"
    |l::a when x=1 -> (replace_liste y l)::a
    |l::a -> l::(replace_element((x-1),y)a)
  in replace_element (x,y) board;;

replace_cell 9 (2,1) ([[0;1;2];[3;4;5];[6;7;8]]);;


(*3.3*)




(*3.4*)

let get_cell_neighborhood (x,y) board =
  let rec get_cell_vois board = match board with
    |[] -> board
    |e::l when e=0 -> get_cell_vois l
    |e::l -> e::(get_cell_vois l)
  in
get_cell_vois ((get_cell (x-1,y-1) board)::(get_cell (x-1,y) board)::(get_cell (x-1,y+1) board)::(get_cell (x,y-1) board)::(get_cell (x,y+1) board)::(get_cell (x+1,y-1) board)::(get_cell (x+1,y) board)::(get_cell (x+1,y+1) board)::[]);;

get_cell_neighborhood (2,1) [[11;12;13;14];[21;22;23;24];[31;32;33;34];[41;42;43;44]];;
