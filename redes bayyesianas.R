library(bnlearn)
Grafo = empty.graph(c('A', 'S', 'T', 'L', 'B', 'E', 'X', 'D'))
Matriz = matrix(0, ncol = 8, nrow = 8, dimnames = list(c('A', 'S', 'T', 'L', 'B', 'E', 'X', 'D'), c('A', 'S', 'T', 'L', 'B', 'E', 'X', 'D')))
Matriz['A', 'T'] = 1
Matriz['S', 'L'] = 1
Matriz['S', 'B'] = 1
Matriz['T', 'E'] = 1
Matriz['L', 'E'] = 1
Matriz['B', 'D'] = 1
Matriz['E', 'X'] = 1
Matriz['E', 'D'] = 1
amat(Grafo) = Matriz
Resp = c("si", "no")
MA = matrix(c(0.01, 0.99), ncol = 2, dimnames = list("Probs", Resp))
MS = matrix(c(0.5, 0.5), ncol = 2, dimnames = list("Probs", Resp))
MT = matrix(c(0.05, 0.95, 0.01, 0.99), ncol = 2, dimnames = list("T"=Resp, "A"=Resp))
ML = matrix(c(0.1, 0.9, 0.01, 0.99), ncol = 2, dimnames = list("L"=Resp, "S"=Resp))
MB = matrix(c(0.6, 0.4, 0.3, 0.7), ncol = 2, dimnames = list("B"=Resp, "S"=Resp))

ME = c(1.0, 0.0, 1.0, 0.0, 1.0, 0.0, 0.0, 1.0)
dim(ME) = c(2,2,2)
dimnames(ME) = list("E"=Resp, "L"=Resp, "T"=Resp)

MX = matrix(c(0.98, 0.02, 0.05, 0.95), ncol = 2,dimnames = list("X"=Resp, "E"=Resp))

MD = c(0.9, 0.1, 0.7, 0.3, 0.8, 0.2, 0.1, 0.9)
dim(MD) = c(2,2,2)
dimnames(MD) = list("D"=Resp, "E"=Resp, "B"=Resp)

Distribucion = custom.fit(Grafo,dist = list(A=MA, S=MS, T=MT, L=ML, B=MB, E=ME, X=MX, D=MD))
plot(Grafo)

#1
cpquery(Distribucion, event=(A=="si"), evidence=(T=="si"))

