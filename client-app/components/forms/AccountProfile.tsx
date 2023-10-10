"use client"

interface Props {
    user: {
        id: string,
        FirstName: string,
        LastName: string,
        Username: string
    };
    btnTitle: string;
}

export const AccountProfile = ({ user, btnTitle } : Props) => {
    return (
        <div>
            Account Profile
        </div>
    
    )
}