# Тоог текстрүү хөрвүүлэгч #

**Ашиглах заавар:** 

[Nuget](https://www.nuget.org/packages/NumberToStringMon/): 

    Install-Package NumberToStringMon
    
Дуудах: 
```cs
var con=new NumberToString.NumberConverter();
string text=con.convert(89,true);//Төгсгөл болгож дуусгах. Ж.ш ... наяан ес
```

Араас нь үг залгах гэж байгаа бол төгсгөлгүй дуудах
```cs
string text=con.convert(89,false);//Төгсгөлгүй. наяан есөн  ~ төгрөг
```
