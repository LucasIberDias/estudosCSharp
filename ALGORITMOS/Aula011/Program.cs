namespace Aula011;

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Arvore<int> tree = new Arvore<int>(1);

        tree.AddFilho(tree.Raiz, 2);
        tree.AddFilho(tree.Raiz, 3);

        tree.Percorrer(tree.Raiz);
    }
}

class TreeNode<T>
{
    public T valor;
    public List<TreeNode<T>> Filhos;

    public TreeNode(T valor)
    {
        this.valor = valor;
        Filhos = new List<TreeNode<T>>();
    }
}

class Arvore<T>
{
    public TreeNode<T> Raiz;

    public Arvore(T valorRaiz)
    {
        Raiz = new TreeNode<T>(valorRaiz);
    }

    public void AddFilho(TreeNode<T> pai, T valorFilho)
    {
        pai.Filhos.Add(new TreeNode<T>(valorFilho));
    }

    public void Percorrer(TreeNode<T> no)
    {
        if (no != null)
        {
            Console.WriteLine(no.valor);

            foreach (var filho in no.Filhos)
            {
                Percorrer(filho);
            }
        }
    }
}