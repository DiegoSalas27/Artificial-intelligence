var cols = 25;
var rows = 25;
var grid = new Array(cols);
var openList = [];
var closedList = [];
var start;
var end;
var w, h;
var path = [];

function heuristic(a, b){
  var d = abs(a.i-b.i) + abs(a.j-b.j);
  return d;
}

function removeFromArray(ele){
  for(var i = openList.length - 1; i >= 0; i--){
    if(openList[i] == ele){
      openList.splice(i, 1);
    }
  }
}

function Spot(i, j){
  this.i = i;
  this.j = j;
  this.f = 0;
  this.g = 0;
  this.h = 0;
  this.neighbors = [];
  this.previous = undefined;

  this.show = function(col){
    fill(col);
    noStroke();
    rect(this.i*w, this.j*h, w-1, h-1);
  }

  this.addNeighbors = function() {
    var i = this.i;
    var j = this.j;

    if(i < cols - 1){
      this.neighbors.push(grid[i + 1][j]);
    }
    if (i > 0){
      this.neighbors.push(grid[i - 1][j]);
    }
    if(j < rows - 1){
      this.neighbors.push(grid[i][j + 1]);
    }
    if(j > 0){
      this.neighbors.push(grid[i][j - 1]);
    }
  }
}

function setup() {
  createCanvas(400, 400);
  console.log("A* search");

  w = width/cols;
  h = height/rows;

  for(var i = 0; i < cols; i++){
    grid[i] = new Array(rows);
  }

  for(var i = 0; i < cols; i++){
    for(var j = 0; j < rows; j++){
      grid[i][j] = new Spot(i, j);
    }
  }

  for(var i = 0; i < cols; i++){
    for(var j = 0; j < rows; j++){
      grid[i][j].addNeighbors();
    }
  }

  start = grid[0][0];
  end = grid[cols-1][3];  

  openList.push(start);
}

function draw() {

  if(openList.length > 0) {

    var winner = 0;
    for(var i = 0; i < openList.length; i++){
        if(openList[i].f < openList[winner].f) {
          winner = i;
        }
    }

    var current = openList[winner];

    if(current === end){
      noLoop();
      console.log("Done");
    }

    removeFromArray(current);
    closedList.push(current);

    var neighbors = current.neighbors;
    for(var i = 0; i < neighbors.length; i++){
      var neighbor = neighbors[i];

      if(!closedList.includes(neighbor)){
        var tempG = current.g + 1;

        if(openList.includes(neighbor)){
          if(tempG < neighbor.g){
            neighbor.g = tempG;
          }
        } else {
          neighbor.g = tempG
          openList.push(neighbor);
        }

        neighbor.h = heuristic(neighbor, end);
        neighbor.f = neighbor.g + neighbor.h;
        neighbor.previous = current;
      }
    }

  } else {
    //no solution
  }
  background(0);

  for(var i = 0; i < cols; i++){
    for(var j = 0; j < rows; j++){
      grid[i][j].show(color(255));
    }
  }

  for(var i = 0; i < closedList.length; i++){
    closedList[i].show(color(255, 0, 0));
  }

  for(var i = 0; i < openList.length; i++){
    openList[i].show(color(0, 255, 0));
  }

  path = [];
  var temp = current;
  path.push(temp)
  while(temp.previous){
    path.push(temp.previous);
    temp = temp.previous;
  }

  for(var i = 0; i < path.length; i++){
    path[i].show(color(0, 0, 255));
  }
}