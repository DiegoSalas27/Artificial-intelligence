r = 3
a = 2
v = 4
n = 9
resultN = nrow(permutations(n, n))
resultB = nrow(permutations(r, r)) * nrow(permutations(a, a)) * nrow(permutations(v, v))
result = resultN/resultB
View(result)