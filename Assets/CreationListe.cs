using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ListeDeCourse
{
    public class CreationListe : ListeCourse
    {
        public InputField article;
        public ScrollRect previewListe;
        public Text Txtprefab;
        public Button Btnprefab;

        void Start()
        {
            article.text = string.Empty;
            base.listeCourse = new List<string>();
        }


        void Update()
        {

        }

        public void ajouterArticle()
        {
            Text newArticle;
            Button newBtnDel;
            newArticle = (Text)Instantiate(Txtprefab, transform);
            newBtnDel = (Button)Instantiate(Btnprefab, transform);
            newArticle.text =  article.text;
            newBtnDel.onClick.AddListener(delegate {Destroy(newArticle.gameObject); Destroy(newBtnDel.gameObject); listeCourse.Remove(newArticle.text);});
            base.listeCourse.Add(article.text);
        }

    }
}