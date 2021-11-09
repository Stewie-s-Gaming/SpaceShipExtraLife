השינוי שבחרתי לעשות במשחק של אראל הוא להוסיף 3 חיים לשחקן, כלומר רק לאחר 3 פגיעות ימות השחקן. 
התוספת שלי למשחק הייתה להוסיף 3 חיים בצד הימין עליון של המסך על מנת לתת לשחקן אינדיקציה לכמה פגיעות נותרו לו.

ניתן לראות בקוד הבא כי הוספתי שדה של hitPoints שמוגדר להיות 3 והוא למעשה קובע כי נותר לשחקן עוד כ3 "חיים".
לאחר כל פגיעה אנחנו מורידים 1 מהשדה והורסים "מד חיים" אחד, כאשר הרסנו את כל 3 החיים של השחקן אנו נהרוס גם את השחקן.
```
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;
    [SerializeField] int hitPoints = 3;
    const int hitLimit = 0;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == triggeringTag && enabled)
        {
            GameObject heart = GameObject.Find("Heart" + hitPoints);
            Destroy(heart);
            hitPoints--;
            if (hitPoints == hitLimit)
            {
                Destroy(this.gameObject);
                Destroy(other.gameObject);
            }
        }
    }
    
 ```
 
