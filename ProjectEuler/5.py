checkList = [11, 13, 14, 16, 17, 18, 19, 20]
startNumber = 2520
stepNumber = 2520

for i in range(startNumber, 999999999, stepNumber):
  if all(i % check == 0 for check in checkList):
    print(i)
    break
