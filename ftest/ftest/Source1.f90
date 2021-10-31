module MyTool
contains
    subroutine Subtract(A,B,C,N)
    !DEC$ ATTRIBUTES DLLEXPORT :: Subtract
    !DEC$ ATTRIBUTES ALIAS: 'Subtract' :: Subtract
    !DEC$ ATTRIBUTES VALUE ::N
    !DEC$ ATTRIBUTES REFERENCE :: A, B, C
    implicit none
    integer::i
    double precision,intent(in) :: A(:),B(:)
    double precision,intent(out) ::C(:)
    integer::N
    DO i=1,N
    C(I)=A(I)+B(I)
    END DO
    return
    end subroutine Subtract
end module MyTool