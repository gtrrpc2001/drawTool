
Public Class ConEnum
    Public Enum ObserverAction
        Invalidate '다시 그리기
        Command   '실행취소와 다시실행
        Rectangle '사각형
        Ellipse   '원
        Line      '줄
        Pencil    '연필
        _Select   '선택
        FileLoad  '불러오기
        FileSave  '저장하기
        _New      '새로 만들기
    End Enum
    Public Enum ObserverName
        MainView   '메인화면
        DrawBox    '그리기 상자
        ToolBar    '상단 툴바
    End Enum
    Public Enum DrawObjectType
        Rectangle   '사각형
        Ellipse     '원
        Line        '줄
        Pencil      '연필
        _Select     '선택
    End Enum
    Public Enum SelectMode
        None           '아무것도 선택되지 않음
        NetSelection   '영역으로 선택
        Move           '이동
        Size           '사이즈 변경
    End Enum
End Class


