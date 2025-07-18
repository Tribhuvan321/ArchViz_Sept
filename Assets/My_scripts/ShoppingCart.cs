using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShoppingCart : MonoBehaviour
{
    public Card card;

    public GameObject Container;
    private Transform SpChildCardTransform;
    private Transform SpCardNameTransform;
    private Transform SpCardPriceTransform;

    private Transform SpCardImgTransform;

    public GameObject SpCardTemplate;

    public Image SpCardImg;
    public TMP_Text SpCardName;
    public TMP_Text SpCardPrice;

    public void Awake()
    {
        SpChildCardTransform = SpCardTemplate.transform.GetChild(0);
        SpCardImgTransform = SpChildCardTransform.GetChild(0);
        SpCardImg = SpCardImgTransform.GetComponent<Image>();

        SpCardNameTransform = SpChildCardTransform.GetChild(1);
        SpCardName = SpCardNameTransform.GetComponent<TMP_Text>();

        SpCardPriceTransform = SpChildCardTransform.GetChild(2);
        SpCardPrice = SpCardPriceTransform.GetComponent<TMP_Text>();

    }

    public void Update()
    {
        if(Container == null)
        {
            Container = GameObject.FindGameObjectWithTag("Container");
        }

    }
    public void AddToCart()
    {
        SpCardName.text = card.item_name;
        SpCardPrice.text = card.item_price;
        SpCardImg.sprite = card.item_img;
        Debug.Log(SpCardName + " " + SpCardPrice);

        Instantiate(SpCardTemplate, Container.transform);
    }
}
