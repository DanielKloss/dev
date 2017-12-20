number1 = 100number2 = 100biggestPaliondrome = 0
while number1 < 1000:  while number2 < 1000:    total = number1 * number2      if str(total) == str(total)[::-1] and total > biggestPaliondrome:      biggestPaliondrome = total        number2 += 1  number1 += 1  number2 = 100    print(biggestPaliondrome)
