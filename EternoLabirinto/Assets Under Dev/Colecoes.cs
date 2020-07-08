using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colecoes : MonoBehaviour
{
    //Declaração Array
    public Candidato[] candidatos;
    //Declaração Lista
    public List<Candidato> candidatosList;
    //Declaração Dicionário
    public Dictionary<string, Candidato> dicionarioCandidato;
    public Dictionary<Candidato, string> dicionarioReverso;
    //Declaração Hashset
    public HashSet<int> hashSet;
    //Declaração HASHABLE
    public Hashtable hashable;

    void Start()
    {
        // Array
        Candidato goku = new Candidato();
        goku.nomeDoCandidato = "Goku";
        goku.numero = 55;
        goku.partido = "Sayajins";

        Candidato cell = new Candidato();
        cell.nomeDoCandidato = "Cell";
        cell.numero = 15;
        cell.partido = "Android";

        //Array é uma coleção fixa e não pode ser alterada
        candidatos = new Candidato[]
        {
            goku, cell
        };









        ///////////////////////////////////
        //LISTA
        ///////////////////////////////////
        //A lista pode adicionar novos elementos dinamicamente
        candidatosList.Add(goku);
        candidatosList.Add(cell);
        //Também é possível remover elementos
        candidatosList.Remove(goku);

        //Para ter acesso a quantidade de elementos em uma lista, utilizamos "Count" no lugar de "length"
        for (int i = 0; i < candidatosList.Count; i++)
        {

        }

        //Para transformar array em uma lista
        candidatosList = new List<Candidato>(candidatos);
        //Para transformar lista em array
        candidatos = candidatosList.ToArray();









        ///////////////////////////
        //DICIONARIO
        ///////////////////////////
        ///Um dicionário possui una KEY e um VALUE que são utilizados em conjunto
        dicionarioCandidato = new Dictionary<string, Candidato>();
        //Para adicionar, é necessário passar a key e o value
        dicionarioCandidato.Add("Goku", goku);
        // Na hora de acessar o valor, você utiliza a KEY que colocou na declaração
        Debug.Log("Meu Numero é: " + dicionarioCandidato["Goku"].numero);
        
        dicionarioReverso = new Dictionary<Candidato, string>();
        dicionarioReverso.Add(cell, "Perdeu lol");
        Debug.Log("Dicionario reverso: " + dicionarioReverso[cell]);






        //////////////////////////
        /// HASHSET
        /////////////////////////
        ///É igual uma lista, entretanto não pode ter elementos repetidos
        hashSet = new HashSet<int>();
        hashSet.Add(10);
        hashSet.Add(15);
        hashSet.Add(20);
        hashSet.Add(15);
        hashSet.Add(10);

        foreach (int item in hashSet)
        {
            Debug.Log(item);
        }







        //////////////////////////
        ///HASHABLE
        //////////////////////////
        ///É igual ao dicionario, entretanto não tem valores nem keys fixos. Você pode utilizar o T que quiser na hora que quiser.
        ///
        hashable = new Hashtable();
        hashable.Add("Goku", goku);
        hashable.Add(55555, "Oi");
        hashable.Add(transform, "Meu Transform");

        Debug.Log(hashable[55555]);
        Candidato newCandidato = hashable["Goku"] as Candidato;
        Debug.Log(newCandidato.partido);
    }

}
