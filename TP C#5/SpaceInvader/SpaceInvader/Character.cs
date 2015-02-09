using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvader
{
    class Character
    {
        int nb_shots; // défini le nombre des tirs du vaisseau
        string design; // l’aspect du vaisseau
        protected int last_shot_time;
        // int stockant le moment du dernier tir du vaisseau
        string refresh_str;
        // string remplie d’espaces afin d’effacer les traces du vaisseau
        int length; // taille de la string design
        int life; // vie du vaisseau
        int x;
        // position sur l’axe x du vaisseau (conseil : évitez de dépasser 79 + length)
        int y; // position sur y ; (23 au max sur la console par défaut)
        List<Shot> shots; // liste contenant tous les tirs lancés par le vaisseau
        int time; // entier contenant le temps de jeu.
    }    
}
