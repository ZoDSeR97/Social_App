"use client"

interface Props {
    user: {
        id: string,
        first_name: string,
        last_name: string,
        username: string
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