using System;

1)  function cToF(celsius)
{
    var cTemp = celsius;
    var cToFahr = cTemp * 9 / 5 + 32;
    var message = cTemp + '\xB0C is ' + cToFahr + ' \xB0F.';
    console.log(message);
}

function fToC(fahrenheit)
{
    var fTemp = fahrenheit;
    var fToCel = (fTemp - 32) * 5 / 9;
    var message = fTemp + '\xB0F is ' + fToCel + '\xB0C.';
    console.log(message);
}
cToF(-40);(0);(50)


2)let a = 3;
let b = 14;

if ((a % b) == 0)
{
    console.log(1)
}
let a = 18;
let b = 2;

if ((a % b) == 0)
{
    console.log(1)
}
let a = 7;
let b = 21;

if ((a % b) == 0)
{
    console.log(0)
}



3)const months = {
  Jan: '01',
  Feb: '02',
  Mar: '03',
  Apr: '04',
  May: '05',
  Jun: '06',
  Jul: '07',
  Aug: '08',
  Sep: '09',
  Oct: '10',
  Nov: '11',
  Dec: '12',
}


4)function max_of_three(x, y, z)
{
    max_val = 0;
    if (x > y)
    {
        max_val = x;
    }
    else
    {
        max_val = y;
    }
    if (z > max_val)
    {
        max_val = z;
    }
    return max_val;
}

console.log(max_of_three(-4, 6, 0));
console.log(max_of_three(14, 8, 14));
console.log(max_of_three(1020, 500, -450))



5)

Math.abs(-123);
Math.abs(35);
Math.abs(0)

