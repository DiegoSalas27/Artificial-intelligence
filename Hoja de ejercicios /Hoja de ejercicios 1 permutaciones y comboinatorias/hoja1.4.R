uno = 3
dos = 1
tres = 4
n = 8
resultN = nrow(permutations(n, n))
resultNum = nrow(permutations(uno, uno)) * nrow(permutations(dos, dos)) * nrow(permutations(tres, tres))
result = resultN/resultNum
View(result)