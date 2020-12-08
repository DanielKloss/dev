file = open("input.txt", "r")
lines = file.read().splitlines()

accumulator = 0
visited = []
i = 0

while i not in visited:
    visited.append(i)

    instruction = lines[i].split(' ')[0]
    operation = lines[i].split(' ')[1][:1]
    data = int(lines[i].split(' ')[1][1:])

    if instruction == "acc":
        if operation == '+':
            accumulator = accumulator + data
        elif operation == '-':
            accumulator = accumulator - data
        i = i + 1
    elif instruction == "jmp":
        if operation == "+":
            i = i + data
        elif operation == "-":
            i = i - data 
    else:
        i = i + 1

print(accumulator)
