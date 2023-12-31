using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaZumbi : MonoBehaviour
{
    public GameObject Jogador;
    public float Velocidade = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate(){     
        
        float distancia = Vector3.Distance(transform.position, Jogador.transform.position);

        Vector3 direcaoJogador = Jogador.transform.position - transform.position;

        Quaternion novaRotacao = Quaternion.LookRotation(direcaoJogador);
        GetComponent<Rigidbody>().MoveRotation(novaRotacao);

        if(distancia > 2.5){
            
            GetComponent<Rigidbody>().MovePosition
                (GetComponent<Rigidbody>().position + 
                direcaoJogador.normalized * Velocidade * Time.deltaTime); 
            GetComponent<Animator>().SetBool("Atacando", false);           
        }
        else{
            GetComponent<Animator>().SetBool("Atacando", true);
        }       
    }
     void AtacaJogador(){
            Time.timeScale = 0;
        }
}
