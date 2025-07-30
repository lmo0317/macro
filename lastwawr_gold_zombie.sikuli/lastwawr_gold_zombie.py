IMG_SPECIAL_EVENT = "1753883006675.png" # 특별 이벤트
IMG_SEARCH_BUTTON = "1753883199807.png" # 검색
IMG_SWORD_ICON   = "1753883242089.png" # 칼그림
IMG_DEPLOY       = "1753883300135.png" # 출정
IMG_RECOVER      = "1753889415228.png" #체력 회복
IMG_USE          = "1752424408616.png" # 사용
IMG_CLOSE         = "1752424441815.png" # X 버튼


#use 버튼 클릭
def click_use_button():
    try:
        matches = list(findAll(IMG_USE))
        count = len(matches)
        print(">> '사용' 버튼 개수: {count}")
        if count == 1:
            print(">> '사용' 버튼 1개 → 클릭")
            click(matches[0])
        elif count >= 2:
            print(">> '사용' 버튼 2개 이상 → 두 번째 클릭")
            click(matches[1])
        else:
            print(">> '사용' 버튼 없음")
            return
        wait(1)
    except FindFailed:
        print(">> '사용' 버튼 찾기 실패 (예외 발생)")

# 체력 회복 처리 함수
def recover_if_needed():
    print(">> 체력 회복 시도")  # 호출 확인용
    if exists(IMG_RECOVER):
        print(">> 체력 회복 버튼 발견")
        click(IMG_RECOVER)
        wait(1)
        click_use_button()        
        click(IMG_CLOSE)
        wait(1)
    else:
        print(">> 체력 회복 버튼 없음")

while True:
    
    click(IMG_SPECIAL_EVENT) #특별 이벤트
    wait(1)

    click(IMG_SEARCH_BUTTON) #검색
    wait(1)
    
    click(IMG_SWORD_ICON) #칼 그림
    wait(1)

    recover_if_needed()  # 함수 호출     
    
    click(IMG_DEPLOY) #출정
    wait(1)
    
    wait(30)