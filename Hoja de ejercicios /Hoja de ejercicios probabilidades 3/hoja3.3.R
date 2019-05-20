# E = {(1,1); (1,2); (1,3); (1,4); (1,5); (1,6); (2,1); ...; (6,6)}
# Utilizando regla de Laplace, los casos favorables son:
# A = {(1,2); (2,1); (1,5); (2,4); (3,3); (4,2); (5,1); (3,6); (4,5); (5,4); (6,3); (6,6)}
# 36 elementos equiprobables

library(gtools)

c = permutations(6, 2, repeats.allowed = T)

dado = expand.grid(lados=c(1:6))
Probs = c(rep(1/6, 6))
dado = data.frame(dado, c, Probs)

sub = subset(dado, (X1 + X2)%%3 ==0)

n = length(sub$X2)

#P(A) = 12/36 = 1/3

P = n / nrow(c)
print(P)


