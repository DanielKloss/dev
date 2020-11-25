primes = [];
number = 1;
 
while len(primes) < 10000:
  number = number + 2
  if number == 1:
    continue

  if number % 2 == 0:
    continue

  counter = 3;

  while (counter * counter) <= number:
    if number % counter == 0:
      break
    else:
      counter = counter + 2

  if (counter * counter) <= number:
    continue
    
  primes.append(number)

print(primes[9999])
