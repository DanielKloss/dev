def runProgram(noun, verb):
  file = open("input.txt", "r")
  fileContents = file.read()
  fileContents = fileContents.split(",")

  total = 0
  fileContents[1] = noun
  fileContents[2] = verb

  for i in range(0,len(fileContents),4):
    if fileContents[i] == "99" or fileContents[i] == 99:
      break
    elif fileContents[i] == "1" or fileContents[i] == 1:
      total = int(fileContents[int(fileContents[i+1])]) + int(fileContents[int(fileContents[i+2])])
      fileContents[int(fileContents[i+3])] = total
    elif fileContents[i] == "2" or fileContents[i] == 2:
      total = int(fileContents[int(fileContents[i+1])]) * int(fileContents[int(fileContents[i+2])])
      fileContents[int(fileContents[i+3])] = total

  if total == 19690720:
    print(100*noun+verb)

for i in range(0,99):
  for j in range(0,99):
    runProgram(i, j)


