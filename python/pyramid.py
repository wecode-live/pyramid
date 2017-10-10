def create_pyramid(rows):
    for i in range(rows):
        print ' '*(rows-i-1) + '*'*(2*i+1)

create_pyramid(10)
