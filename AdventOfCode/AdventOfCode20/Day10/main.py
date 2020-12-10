file = open("input.txt", "r")
lines = file.read().splitlines()

class AdapterManager():
    currentJolts = 0
    numberOfAdapters = 0
    threes = 1
    ones = 0

    def __init__(self, lines):
        self.lines = lines

    def findNextAdapter(self):
        currentDifference = 4
        newJolts = 0
        for line in self.lines:
            difference = int(line) - self.currentJolts
            if difference > 0 and difference < currentDifference:
                currentDifference = difference
                newJolts = int(line)
        self.currentJolts = newJolts
        if currentDifference == 3:
            self.threes = self.threes + 1
        elif currentDifference == 1:
            self.ones = self.ones + 1
        self.numberOfAdapters = self.numberOfAdapters + 1

adapterManager = AdapterManager(lines)

while adapterManager.numberOfAdapters != len(lines):
    adapterManager.findNextAdapter()
print(adapterManager.threes*adapterManager.ones)
