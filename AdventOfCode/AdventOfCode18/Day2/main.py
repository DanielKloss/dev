file = open("input.txt", "r")
fileLines = file.read()
lines = fileLines.split('\n')

doubles = 0
triples = 0
for idNumber in lines:
    usedLetters = []
    doubleFound = False
    tripleFound = False
    for i in range(0, len(idNumber)):
        count = 1
        if idNumber[i] in usedLetters:
            continue
        for j in range(i+1, len(idNumber)):
            if idNumber[i] == idNumber[j]:
                count = count+1
        if count == 2:
            doubleFound = True
        elif count == 3:
            tripleFound = True
        usedLetters.append(idNumber[i])
    if doubleFound == True:
        doubles = doubles + 1
    if tripleFound == True:
        triples = triples + 1

print(str(doubles) + "*" + str(triples))
print(doubles * triples)

for i in range(0, len(lines)):
        for j in range(i+1, len(lines)):
            count = 0
            string = ""
            for k in range(0, len(lines[i])):
                if lines[i][k] != lines[j][k]:
                    count = count+1
                    if count == 2:
                        break
                else:
                    string = string + lines[i][k]

            if count == 1:
                print(lines[i] + "\n" + lines[j])
                print(string)
