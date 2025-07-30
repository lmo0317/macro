IMG_SPECIAL_EVENT = "1753883006675.png" # 특별 이벤트
IMG_SEARCH_BUTTON = "1753883199807.png" # 검색
IMG_SWORD_ICON   = "1753883242089.png" # 칼그림
IMG_DEPLOY       = "1753883300135.png" # 출정
IMG_RECOVER      = "1752424291782.png" # 체력 회복
IMG_USE          = "1752424408616.png" # 사용
IMG_CLOSE         = "1752424441815.png" # X 버튼

while True:
    
    click(IMG_SPECIAL_EVENT) #특별 이벤트
    wait(1)

    click(IMG_SEARCH_BUTTON) #검색
    wait(1)
    
    click(IMG_SWORD_ICON) #칼 그림
    wait(1)

    if exists(IMG_RECOVER):
        click(IMG_RECOVER) #체력 회복
        wait(1)

        click(IMG_USE) #사용
        wait(1)

        click(IMG_CLOSE) #닫기
     
    
    click(IMG_DEPLOY) #출정
    wait(1)
    
    wait(30)