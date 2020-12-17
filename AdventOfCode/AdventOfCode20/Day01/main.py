file = open("input.txt", "r")
fileLines = file.read()
lines = fileLines.split('\n')

for i in range(len(lines)):
    for j in range(i+1, len(lines)):
        if int(lines[i]) + int(lines[j]) == 2020:
            print(int(lines[i]) * int(lines[j]))
        for k in range(j+1, len(lines)):
            if int(lines[i]) + int(lines[j]) + int(lines[k]) == 2020:
                print(int(lines[i]) * int(lines[j]) * int(lines[k]))












