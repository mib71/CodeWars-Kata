/*
## JavaScript Array Filter

The solution would work like the following:
```
getEvenNumbers([2,4,5,6]) // should == [2,4,6]
```

https://www.codewars.com/kata/514a6336889283a3d2000001/typescript
*/

export const getEvenNumbers = (numbersArray: number[]): number[] => {
  let res = []
  for (let i = 0; i < numbersArray.length; i++) {
    if (!(numbersArray[i] % 2)) {
      res.push(numbersArray[i])
    }
  }
  return res
}
