IMG_SPECIAL_EVENT = "1753892268982.png" # 특별 이벤트
IMG_SEARCH_BUTTON = "1753892300669.png" # 검색
IMG_SWORD_ICON   = "1753892320825.png" # 칼그림
IMG_DEPLOY       = "1753892339850.png" # 출정
IMG_RECOVER      = "1753892371144.png" #체력 회복
IMG_USE          = "1753892388978.png" # 사용
IMG_CLOSE         = "1753892408517.png" # X 버튼

#use 버튼 클릭
def click_use_button():
    try:
        matches = list(findAll(Pattern(IMG_USE).similar(0.5)))
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
    if exists(Pattern(IMG_RECOVER).similar(0.5)):
        print(">> 체력 회복 버튼 발견")
        click(Pattern(IMG_RECOVER).similar(0.5))
        wait(1)
        click_use_button()        
        click(Pattern(IMG_CLOSE).similar(0.5))
        wait(1)
    else:
        print(">> 체력 회복 버튼 없음")

while True:
    try:
        click(Pattern(IMG_SPECIAL_EVENT).similar(0.5))  # 특별 이벤트
        wait(1)
        click(Pattern(IMG_SEARCH_BUTTON).similar(0.5))  # 검색
        wait(1)
        click(Pattern(IMG_SWORD_ICON).similar(0.5))     # 칼 그림
        wait(1)
        recover_if_needed()                             # 체력 회복
        click(Pattern(IMG_DEPLOY).similar(0.5))         # 출정
        wait(1)
        wait(30)  # 다음 루프 대기
    except FindFailed:
        print(">> 루프 중 예외 발생. ESC 키 누름 후 계속 진행")
        type(Key.ESC)
        wait(1)
        continue