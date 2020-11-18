file = open("input.txt", "r")
fileLines = file.read()
routes = fileLines.split('\n')
route1 = routes[0].split(',')
route2 = routes[1].split(',')

startX = 0
startY = 0

def TraceRoute(route, startX, startY):
    currentX = startX
    currentY = startY
    routeTrace = []
    stepsTrace = []
    steps = 0
    for step in route:
        distance = step[1:]
        distance = int(distance)
        if step[0] == "R":
            for i in range(distance):
                currentX = currentX+1
                steps = steps+1
                routeTrace.append((currentY, currentX))
                stepsTrace.append(steps)
        elif step[0] == "L":
            for i in range(distance):
                currentX = currentX-1
                steps = steps+1
                routeTrace.append((currentY, currentX))
                stepsTrace.append(steps)
        elif step[0] == "U":
            for i in range(distance):
                currentY = currentY+1
                steps = steps+1
                routeTrace.append((currentY, currentX))
                stepsTrace.append(steps)
        elif step[0] == "D":
            for i in range(distance):
                currentY = currentY-1
                steps = steps+1
                routeTrace.append((currentY, currentX))
                stepsTrace.append(steps)

    return routeTrace, stepsTrace

routeTrace1, stepsTrace1 = TraceRoute(route1, startX, startY)
routeTrace2, stepsTrace2 = TraceRoute(route2, startX, startY)

route1CoOrdinates = set(routeTrace1)
route2CoOrdinates = set(routeTrace2)

crossoverCoOrdinates=route1CoOrdinates.intersection(route2CoOrdinates)

closestToZeroZero = None
closestDistance = None

for coordinate in crossoverCoOrdinates:
    distance = abs(int(coordinate[0])) + abs(int(coordinate[1]))
    if closestDistance == None or distance < closestDistance:
        closestToZeroZero = coordinate
        closestDistance = distance

print(closestDistance)
print(closestToZeroZero)

fewestStepsToZeroZero = None
fewestSteps = None

for coordinate in crossoverCoOrdinates:
    indexInTrace1 = routeTrace1.index(coordinate)
    indexInTrace2 = routeTrace2.index(coordinate)

    steps = int(stepsTrace1[indexInTrace1]) + int(stepsTrace2[indexInTrace2])

    if fewestSteps == None or steps < fewestSteps:
        fewestStepsToZeroZero = coordinate
        fewestSteps = steps

print(fewestSteps)
print(fewestStepsToZeroZero)
