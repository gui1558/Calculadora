using System;
using System.Collections.Generic;

class Pilha<P>
{
    private Stack<P> pilha = new Stack<P>();

    public void Empilhar(P valor)
    {
        pilha.Push(valor);
    }

    public P Desempilhar()
    {
        if (pilha.Count > 0)
        {
            return pilha.Pop();
        }
        else
        {
            throw new InvalidOperationException("A pilha está vazia.");
        }
    }
}
