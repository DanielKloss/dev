file = open("input.txt", "r")
fileLines = file.read()
lines = fileLines.split('\n')

answer = 0
answers = set()
repeatNotFound = True

while repeatNotFound:
    for instruction in lines:
        symbol = instruction[:1]
        number = instruction[1:]
        if symbol == '+':
            answer = answer + int(number)
        elif symbol == '-':
            answer = answer - int(number)
        if answer in answers:
            print("repeated: " + str(answer))
            repeatNotFound = False
            break
        answers.add(answer)

print("final " + str(answer))
