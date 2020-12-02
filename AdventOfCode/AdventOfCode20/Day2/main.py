file = open("input.txt", "r")
fileLines = file.read()
lines = fileLines.split('\n')

def readFile(password):
    parts = password.split(" ")
    numberParts = parts[0].split("-")
    lowest = int(numberParts[0])
    highest = int(numberParts[1])
    letterParts = parts[1].split(":")
    letter = letterParts[0]
    password = parts[2]
    return lowest, highest, letter, password

def partOne():
    validPasswords = 0

    for password in lines:
        lowest, highest, letter, password = readFile(password)
        count = 0

        for passwordLetter in password:
            if passwordLetter == letter:
                count = count+1
                if count > highest:
                    break

        if count >= lowest and count <= highest:
            validPasswords = validPasswords + 1

    print(validPasswords)

def partTwo():
    validPasswords = 0

    for password in lines:
        positionOne, positionTwo, letter, password = readFile(password)
        positionOne = positionOne - 1
        positionTwo = positionTwo - 1
        count = 0

        for i in range(len(password)):
            if password[i] == letter:
                if i == positionOne:
                    count = count + 1
                elif i == positionTwo:
                    count = count + 1

        if count == 1:
            validPasswords = validPasswords + 1

    print(validPasswords)

partOne()
partTwo()










