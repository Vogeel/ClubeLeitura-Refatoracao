using System;

public class RepositorioAmigos
{
	public RepositorioAmigos()
	{

          public Amigos[] amigos;
    public int numeroamigos;

    public void Inserir(Amigos amigo)
    {
        amigo.numero = ++numeroamigos;

        int posicaoVazia = ObterPosicaoVazia();
        amigos[posicaoVazia] = amigo;
    }

    public void Editar(int numeroSelecioando, Amigos amigos)
    {
        for (int i = 0; i < amigos.Length; i++)
        {
            if (amigos[i].numero == numeroSelecioando)
            {
                amigos.numero = numeroSelecioando;
                amigos[i] = caixa;

                break;
            }
        }
    }

    public void Excluir(int numeroSelecionado)
    {
        for (int i = 0; i < amigos.Length; i++)
        {
            if (amigos[i].numero == numeroSelecionado)
            {
                amigos[i] = null;
                break;
            }
        }
    }

    public bool AmigoJaCadastrado(string amigoInformado)
    {
        bool amigoJaCadastrado = false;
        for (int i = 0; i < amigos.Length; i++)
        {
            if (amigos[i] != null && amigos[i].nome == amigoInformado)
            {
                amigoInformado = true;
                break;
            }
        }

        return amigoInformado;
    }

    public bool VerificarNumeroAmigosExiste(int numeroamigos)
    {
        bool NumeroAmigosEncontrado = false;

        for (int i = 0; i < amigos.Length; i++)
        {
            if (amigos[i] != null && amigos[i].numero == numeroamigos)
            {
                NumeroAmigosEncontrado = true;
                break;
            }
        }

        return NumeroAmigosEncontrado;
    }

    public int ObterPosicaoVazia()
    {
        for (int i = 0; i < amigos.Length; i++)
        {
            if (amigos[i] == null)
                return i;
        }

        return -1;
    }

    public Amigos[] SelecionarTodos()
    {
        int quantidadeamigos = ObterQtdamigos();

        Amigos[] amigosInseridas = new Amigos[quantidadeamigos];

        for (int i = 0; i < amigos.Length; i++)
        {
            if (amigos[i] != null)
                amigosInseridas[i] = amigos[i];
        }

        return amigosInseridas;
    }

    public int ObterQtdamigos()
    {
        int numeroamigos = 0;

        for (int i = 0; i < amigos.Length; i++)
        {
            if (amigos[i] != null)
                numeroamigos++;
        }
    }
}
