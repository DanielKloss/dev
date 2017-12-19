count = 0
number = int(input("What number do you want to know the Collatz Conjecture for?"))
while number > 1:  if number % 2 == 0:    number = number / 2  else:    number = (number * 3) + 1    print(number)  count += 1  print(count)
