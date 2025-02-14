using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessSpecifier
{
    public class Program
    {
       

        public void test1() {
            Console.WriteLine("public function is called");
        }

        private void test2() {

            Console.WriteLine("private function is called");
        }

        protected void test3() {
            Console.WriteLine("protected function is called");
        }

        internal void test4() {
            Console.WriteLine("internal function is called");
        }

        protected internal void test5() {
            Console.WriteLine("protected internal function is called");
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.test1();
            p.test2();
            p.test3();
            p.test4();
            p.test5();
        }

    }
}
