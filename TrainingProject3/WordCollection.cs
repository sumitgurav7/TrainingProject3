using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProject3
{
    class WordCollection
    {
        private string[] words = new string[3];

        public string this[int index]
        {
            get => words[index];

            set => words[index] = value; // here I am using indexers
        }
    }
}
