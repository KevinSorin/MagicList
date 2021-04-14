using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ListeDeCourse
{
    public class ListeCourse : MonoBehaviour
    {
        public List<string> listeCourse;
        public Text ArticleName;

        void Start()
        {
            afficherListe();
        }

        // Update is called once per frame
        void Update()
        {

        }


        public void afficherListe()
        {
            Text article;

            foreach(string txt in listeCourse)
            {
                article = (Text)Instantiate(ArticleName, transform);
                article.text = txt;

            }
        }

        public void setlisteCourse(Transform liste)
        {
            Text[] articles = liste.GetComponents<Text>();

            foreach(Text txt in articles)
                listeCourse.Add(txt.text);
        }
    }
}
