class StormEvader():
    lines = None
    directions = {
    "N":["W", "E"],
    "W":["S", "N"],
    "S":["E", "W"],
    "E":["N", "S"]
    }
    northSouth = 0
    westEast = 0
    currentDirection = "E"

    def readFile(self):
        file = open("input.txt", "r")
        self.lines = file.read().splitlines()

    def move(self, distance, direction):
        if direction == "E":
            self.westEast = self.westEast - distance
        elif direction == "W":
            self.westEast = self.westEast + distance
        elif direction == "S":
            self.northSouth = self.northSouth - distance
        elif direction == "N":
            self.northSouth = self.northSouth + distance

    def spin(self, action, value):
        for i in range(int(value/90)):
            if action == "R":
                self.currentDirection = self.directions[self.currentDirection][1]
            elif action == "L":
                self.currentDirection = self.directions[self.currentDirection][0]

    def findRoute(self):
        for line in self.lines:
            action = line[:1]
            value = int(line[1:])
            if action == "F":
                self.move(value, self.currentDirection)
            elif action == "R" or action == "L":
                self.spin(action, value)
            else:
                self.move(value, action)

stormEvader = StormEvader()
stormEvader.readFile()
stormEvader.findRoute()
distance = abs(stormEvader.northSouth) + abs(stormEvader.westEast)
print(distance)

