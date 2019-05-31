# Тоог текстрүү хөрвүүлэгч #

**Ашиглах заавар:** 

Nuget: [View](https://www.nuget.org/packages/NumberToStringMon/)

    Install-Package NumberToStringMon
    
Дуудах: 
```cs
var con=new NumberToString.NumberConverter();
string text=con.convert(123456789,true);//Төгсгөл болгож дуусгах. Ж.ш ... наяан ёс
```

Араас нь үг залгах гэж байгаа бол төгсгөлгүй дуудах
```cs
string text=con.convert(123456789,true);//Төгсгөлгүй наяан ёсөн
```
