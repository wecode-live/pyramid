function createPyramid(height) {
    
    for(let i = 1; i <= height; i++) {
        let row = '';
        for(let j = 1; j <= i; j++) {
            row += '*';
        }
        console.log(row);
    }
}

createPyramid(6);