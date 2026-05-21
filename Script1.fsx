let L1 = [1; 2; 3; 4; 5]
let L2 = [3..2..11]
// 7er-Reihe vorwärts: 7, 14, 21, ... 70
let L3 = [7..7..70]
// 7er-Reihe rückwärts
let L4 = [70..-7..0]

// A - Z
let L5 = ['A' .. 'Z']

// L6: Fügen Sie 0 an vorne an
let L6 = 0 :: L3

// L7: Fügen Sie 0 am Ende an
let L7 = L3 @ [0]

// Teilen Sie L3 in a (Head) und L8 (Tail)
let a :: L8 = L3

// L9: Hängen Sie L2 an L3 an
let L9 = L3 @ L2
