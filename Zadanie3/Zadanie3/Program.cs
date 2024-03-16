// See https://aka.ms/new-console-template for more information
using Zadanie3;


Tree tree1 = new("Tree1");
Tree tree2 = new("Tree2");
Tree tree3 = new("Tree3");
Tree tree4 = new("Tree4");

tree1.SetChild(new Tree("Child1-1"));
tree1.SetChild(new Tree("Child1-2"));
tree1.SetChild(new Tree("Child1-3"));

tree2.SetChild(new Tree("Child2-1"));
tree2.SetChild(new Tree("Child2-2"));


tree3.SetChild(new Tree("Child3-1"));
tree3.SetChild(new Tree("Child3-2"));

tree4.SetChild(new Tree("Child4-1"));

tree1.SetChild(tree2);
tree1.SetChild(tree3);
tree2.SetChild(tree4);

tree1.GetInfo();




