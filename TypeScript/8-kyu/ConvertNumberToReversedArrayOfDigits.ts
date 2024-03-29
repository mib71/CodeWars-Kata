/*
 ## 8 kyu Convert number to reversed array of digits
### Task:

Given a random non-negative number, you have to return the digits of 
this number within an array in reverse order.

### Example:
```
348597 => [7,9,5,8,4,3]
0 => [0]
```

[Link to the Kata](https://www.codewars.com/kata/5583090cbe83f4fd8c000051/typescript)
 */

export const digitize = (n: number): number[] => {
  return n.toString().split('').reverse().map(Number)
}
