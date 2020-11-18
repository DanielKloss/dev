file = open("input.txt", "r")
fileContents = file.readlines()

totalFuel = 0

for line in fileContents:
  newFuel = int(int(line)/3)-2
  totalFuel = totalFuel + newFuel

  while int(int(newFuel)/3)-2 > 0:
    newFuel = int(int(newFuel)/3)-2
    totalFuel = totalFuel + newFuel

print(totalFuel)
