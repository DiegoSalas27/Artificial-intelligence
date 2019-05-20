dado = expand.grid(lados=c(1:6))
Probs = c(rep(1/6, 6))
dado = data.frame(dado, Probs)

sub = subset(dado, lados < 5)

Prob = function(Conjunto) {
  return(sum(Conjunto$Probs))
}

print(Prob(sub))
