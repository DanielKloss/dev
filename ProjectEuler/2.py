number1 = 1number2 = 2total = 2sum = 0
while number2 < 4000000:  if total % 2 == 0:    sum += total      total = number1 + number2  number1 = number2  number2 = total  print(sum)
