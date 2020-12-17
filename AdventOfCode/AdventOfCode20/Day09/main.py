file = open("input.txt", "r")
lines = file.read().splitlines()

previous25 = []

def setupPreamble():
    for i in range(25):
        previous25.append(lines[i])

def checkAdditions(i):
    for j in range(25):
        for k in range(j+1, 25):
            if int(previous25[j])+int(previous25[k]) == int(lines[i]):
                return True
    return False

def addNextNumber(currentPosition, currentNumber):
    currentNumber = int(currentNumber) + int(lines[currentPosition+1])
    if currentNumber == invalidNumber:
        return currentPosition + 1
    elif currentNumber < int(invalidNumber):
        return addNextNumber(currentPosition+1, currentNumber)
    else:
        return -1

def partOne():
    for i in range(25, len(lines)):
        if checkAdditions(i) == False:
            return lines[i]
        else:
            previous25.pop(0)
            previous25.append(lines[i])

def partTwo():
    smallestNumber = 0
    largestNumber = 0
    for i in range(len(lines)):
        highestPosition = addNextNumber(i, lines[i])
        if highestPosition != -1:
            for j in range(i, highestPosition+1):
                if int(lines[j]) > largestNumber:
                    largestNumber = int(lines[j])
                if int(lines[j]) < smallestNumber or smallestNumber == 0:
                    smallestNumber = int(lines[j])
            return smallestNumber + largestNumber

setupPreamble()
invalidNumber = int(partOne())
print(invalidNumber)
encryptionCode = partTwo()
print(encryptionCode)
