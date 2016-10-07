using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avatar
{
    class Program
    {
        static void Main(string[] args)
        {
            Person xiaolu = new Person("小鹿");
            xiaolu = new TShirts().Decorate(xiaolu);
            xiaolu = new BigTrouser().Decorate(xiaolu);
            xiaolu = new Sneakerscs().Decorate(xiaolu);
            xiaolu.Show();
        }
    }
}
