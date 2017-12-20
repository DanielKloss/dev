number = 600851475143factor = 2lastFactor = 1
while number > 1:  if number % factor == 0:    lastFactor = factor    number = number / factor
    while number % factor == 0:      number = number / factor  factor = factor + 1
print(lastFactor)
