let ogrenci=
{
    ad: "Engin",
    yas: 47,
    email: "enginniyazi@gmail.com",
    dersler: 
    [
        {ad:"Matematik", not: 95},
        {ad:"Fizik", not: 75},
        {ad:"Kimya", not: 80}
    ],

    login()
    {
        alert("Öğrenci Giriş Yaptı.")
    },

    logout()
    {
        alert("Öğrenci Çıkış Yaptı.")
    },

    printLessons()
    {
        // for(let i = 0; i < this.dersler.length; i++)
        // {
        //     console.log(this.dersler[i]);
        // }
    
        //this.dersler.forEach(ders => {console.log(ders)})
        this.dersler.forEach
        (
            ders => {console.log(ders.ad, ders.not)}    
        )
    }
};

console.log(ogrenci.ad);
console.log(ogrenci["email"]);
ogrenci.yas=48;
console.log(ogrenci.yas);
console.log(typeof(ogrenci.email));
console.log(typeof(ogrenci.dersler));
console.log(typeof(ogrenci));

// ogrenci.login();
// ogrenci.logout();
ogrenci.printLessons();