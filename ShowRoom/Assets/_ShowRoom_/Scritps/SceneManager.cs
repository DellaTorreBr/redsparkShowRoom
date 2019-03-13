using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class SceneManager : MonoBehaviour
{
    
    private float currentCarPrice = 0f; //Preço do carro selecionado

    public GameObject menu; //Referencia ao GameObject do menu
    
    public Text textPrice; //Referencia ao Objeto Texto para mostrar o preco do Carro

    public List<GameObject> cars; //Lista de carros
    public List<float> carPrices; //Lista de Precos dos carros
    
    // Start is called before the first frame update
    void Start() {
        ChangeCar(0); //Garante a selecao do carro primeiro carro da lista
    }

    // Update is called once per frame
    void Update() {
        
    }

    /// <summary>
    /// Mostra o carro selecionado na tela
    /// </summary>
    /// <param name="carNumber">Indice do carro selecionado na lista de carros</param>
    public void ChangeCar(int carNumber) {
        //Desabilita todos os carros da cena
        foreach (GameObject car in cars) {
            car.SetActive(false);
        }
        
        //Seta o preco do carro selecionado no preco corrente
        currentCarPrice = carPrices[carNumber];
        //Habilita o carro selecionado
        cars[carNumber].SetActive(true);

        //Mostra o valor do carro em parcela unica
        ShowPrice(1);
    }

    /// <summary>
    /// Calcula e mostra o valor das parcelas do carro selecionado
    /// </summary>
    /// <param name="installments">Numero de parcelas para calcular o valor por parcelas</param>
    public void ShowPrice(float installments) {
        float installmentValue = currentCarPrice / installments;
        textPrice.text = String.Format("{0}x de {1}", 
                installments.ToString(), 
                installmentValue.ToString("0.00"));
    }

    /// <summary>
    /// Abre ou fecha o menu
    /// </summary>
    public void ToggleMenu() {
        if(menu != null) {
            Animator animator = menu.GetComponent<Animator>();
            if (animator != null) {
                bool isOpen = animator.GetBool("isOpen");
                animator.SetBool("isOpen", !isOpen);
            }
        }
    }
}
