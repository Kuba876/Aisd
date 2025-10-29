using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Element
    {






        public int wartosc;
        public Element next;
        public Element prev;

        public Element(int wartosc=0,Element next=null,Element prev=null)
        {
            this.prev = prev;
            this.wartosc = wartosc;
            this.next = next;


        }




    }
}
