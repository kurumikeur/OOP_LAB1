using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
{
    public class Tree
    {
        public string ID { get; protected set; }

        public virtual List<Tree> ChildNodes { get; protected set; }

        public Tree(string ID1)
        {
            ID = ID1;
            ChildNodes = new List<Tree>();  
        }
        public void SetChild(Tree child) { ChildNodes.Add(child); }

        protected string GetID() { return ID.ToString(); }

        public List<Tree> GetList()
        {
            List<Tree> buff = new();
            //Console.WriteLine("Parent: " + GetID());
            foreach (Tree child in GetChildNodes(ChildNodes))
                buff.Add(child);
            return buff;
               // Console.WriteLine("Child: " + child.ID.ToString());
        }

        protected IEnumerable<Tree> GetChildNodes(List<Tree> ChildNodes)
        {
            foreach (Tree child in ChildNodes)
            {
                yield return child;
                foreach (Tree child2 in GetChildNodes(child.ChildNodes))
                    yield return child2;
            }
        }

    }
}
