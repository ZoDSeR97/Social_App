"use client"

import { FormEvent, useState } from "react";
import { z } from 'zod'

interface Props {
    user: {
        id: string,
        first_name: string,
        last_name: string,
        username: string
    };
    btnTitle: string;
}

export const AccountProfile = async ({ user, btnTitle }: Props) => {
    const onSubmit = async (event: FormEvent<HTMLFormElement>) => {
        event.preventDefault()

        const formData = new FormData(event.currentTarget)
        const response = await fetch('/User/Create', {
            method: 'POST',
            body: formData,
        })

        // Handle response if necessary
        const data = await response.json()
        // ...
    }
    return (
        <div>
            Account Profile
            <form onSubmit={onSubmit}>
                <input type="text" name="name" />
                <button type="submit">Submit</button>
            </form>
        </div>
    
    )
}
