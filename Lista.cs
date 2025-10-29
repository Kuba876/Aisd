using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Lista
    {
        public Lista(Element head = null,Element tail=null)
        {
            this.tail = tail;
            this.liczba_elementow = 0;
            this.head = head;

        }



        public Element head;
        public Element tail;
        readonly int liczba_elementow;

        void Dodaj_za(Element e, int liczba)
        {

            if (liczba_elementow > 0)
            {
                if (e.next == null)
                {
                    Element nowy = new Element(liczba, null, e);
                    this.tail = nowy;
                    e.next = nowy;
                }
                else
                {
                    Element nowy = new Element(liczba, e.next, e);
                    e.next = nowy;
                    nowy.next.prev = nowy;
                }

            }
            else
            {
                Element nowy = new Element(liczba, null, null);
                this.head = nowy;
                this.tail = nowy;
            }
            this.liczba_elementow++;

        }
        

        void Dodaj_przed(Element e, int liczba)
        {
            if (liczba_elementow > 0)
            {
                if (e.prev == null)
                {
                    Element nowy = new Element(liczba, e, null);
                    this.head = nowy;
                    e.prev = nowy;
                }
                else
                {
                    Element nowy = new Element(liczba, e, e.prev);
                    e.prev.next = nowy; 
                    e.prev = nowy;
                    
                }

            }
            else
            {
                Element nowy = new Element(liczba, null, null);
                this.head = nowy;
                this.tail = nowy;
            }
            this.liczba_elementow++;


        }
        string toString(string sep = ", ")
        {
            string a = "";
            if (this.head != null)
            {
                Element obecny = this.head;
                while (obecny.next != null)
                {
                    a = string.Format("{0}{1}", a, obecny.wartosc);
                    obecny = obecny.next;
                }
                return a;
            }
            else
            {
                return a;
            }


        }
        int[] toArray()
        {
            int[] a = new int[this.liczba_elementow];
            if (this.head != null)
            {
                Element obecny = this.head;
                for(int i = 0; i < this.liczba_elementow; i++)
                {
                    a[i] = obecny.wartosc;
                    obecny = obecny.next;
                }
            }
            else
            {
                return a;
            }


        }



    }
}
