using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Des_moules_et_des_gateaux
{
    class BinaryTree
    {
        BinaryTree _left;
        BinaryTree _right;
        string _root;

        public void BinaryTree()
        {
            _left = null;
            _right = null;
            _root = null;
        }

        public void BinaryTree (string r, BinaryTree left, BinaryTree right)
        {
            _left = left;
            _right = right;
            _root = r;
        }

        public BinaryTree Left
        {
            get {return _left; }
            set {_left = value;}
        }

        public BinaryTree Right
        {
            get {return _right;}
            set {_right = value;}
        }

        public string Root()
        {
            return _root;
        }
    }
}
