"use client"

import { FormEvent } from "react";
import { redirect } from "next/navigation";
import Image from "next/image";
import { UserValidation } from "@/lib/validations/user";
import { getIconComponent } from "@/components/shared/Utilities";

interface Props {
    user: {
        id: string,
        first_name: string,
        last_name: string,
        username: string,
        email: string,
        bio: string,
        image: string,
    };
    btnTitle: string,
}

// Apparently Next.js don't like hook in client component
// Contradict with React
export const AccountProfile = async ({ user, btnTitle }: Props) => {

    const onSubmit = async (event: FormEvent<HTMLFormElement>) => {
        event.preventDefault();

        const formData = new FormData(event.currentTarget);
        const parsed = UserValidation.safeParse({
            FirstName: formData.get('first-name'),
            LastName: formData.get('last-name'),
            Username: formData.get('username'),
            Bio: formData.get('bio'),
            Email: formData.get('email'),
            Password: formData.get('password'),
            Avatar: formData.get('image')
        });
        if (parsed.success) {
            const response = await fetch('http://localhost:5030/api/User', {
                method: 'POST',
                body: formData,
            });
            // Handle response if necessary
            const data = await response.json();
            // ...
            if (data.ok) {
                redirect(`/`);
            }
        }
        
    }
    return (
        <form onSubmit={onSubmit}>
            <div className="space-y-12">
                <div className="border-b border-gray-900/10 pb-12">
                    <p className="mt-1 text-sm leading-6 text-white">
                        This information will be displayed publicly so be careful what you share.
                    </p>

                    <div className="col-span-full">
                        <label htmlFor="photo" className="block text-sm font-medium leading-6 text-gray-900">
                            Avatar
                        </label>
                        <div className="mt-2 flex items-center gap-x-3">
                            {
                                user.image?
                                    <Image src={user.image} alt="avatar" width={28} height={28} className="h-12 w-12 text-gray-300 rounded-md" aria-hidden="true" />
                                    :
                                    getIconComponent("IoPersonOutline")
                            }
                            <button
                                type="button"
                                className="rounded-md px-2.5 py-1.5 text-sm font-semibold text-white shadow-sm ring-1 ring-inset ring-gray-300 hover:text-gray-400"
                            >
                                Change
                            </button>
                        </div>
                    </div>

                    <div className="mt-10 grid grid-cols-1 gap-x-6 gap-y-8 sm:grid-cols-6">
                        <div className="sm:col-span-4">
                            <label htmlFor="username" className="account-form_input-label">
                                Username
                            </label>
                            <div className="mt-2">
                                <div className="flex rounded-md shadow-sm ring-1 ring-inset ring-gray-300 focus-within:ring-2 focus-within:ring-inset focus-within:ring-indigo-600 sm:max-w-md">
                                    <input
                                        type="text"
                                        name="username"
                                        id="username"
                                        defaultValue={ user?.username }
                                        autoComplete="username"
                                        className="block flex-1 border-0 bg-transparent py-1.5 pl-1 text-white placeholder:text-gray-400 focus:ring-0 sm:text-sm sm:leading-6"
                                        placeholder="username"
                                    />
                                </div>
                            </div>
                        </div>

                        <div className="col-span-full">
                            <label htmlFor="bio" className="account-form_input-label">
                                About
                            </label>
                            <div className="mt-2">
                                <textarea
                                    id="bio"
                                    name="bio"
                                    rows={3}
                                    className="account-form_input"
                                    defaultValue={''}
                                />
                            </div>
                            <p className="mt-3 text-sm leading-6 text-gray-400">Write a few sentences about yourself.</p>
                        </div>
                    </div>
                </div>

                <div className="border-b border-gray-900/10 pb-12">
                    <h2 className="text-base font-semibold leading-7 text-white">Personal Information</h2>

                    <div className="mt-10 grid grid-cols-1 gap-x-6 gap-y-8 sm:grid-cols-6">
                        <div className="sm:col-span-3">
                            <label htmlFor="first-name" className="account-form_input-label">
                                First Name
                            </label>
                            <div className="mt-2">
                                <input
                                    type="text"
                                    name="first-name"
                                    id="first-name"
                                    defaultValue={ user?.first_name }
                                    autoComplete="given-name"
                                    className="account-form_input"
                                />
                            </div>
                        </div>

                        <div className="sm:col-span-3">
                            <label htmlFor="last-name" className="account-form_input-label">
                                Last Name
                            </label>
                            <div className="mt-2">
                                <input
                                    type="text"
                                    name="last-name"
                                    id="last-name"
                                    defaultValue={ user?.last_name }
                                    autoComplete="family-name"
                                    className="account-form_input"
                                />
                            </div>
                        </div>

                        <div className="sm:col-span-4">
                            <label htmlFor="email" className="account-form_input-label">
                                Email Address
                            </label>
                            <div className="mt-2">
                                <input
                                    id="email"
                                    name="email"
                                    type="email"
                                    defaultValue={ user?.email }
                                    autoComplete="email"
                                    className="account-form_input"
                                />
                            </div>
                        </div>

                        <div className="sm:col-span-4">
                            <label htmlFor="password" className="account-form_input-label">
                                Password
                            </label>
                            <div className="mt-2">
                                <input
                                    id="password"
                                    name="password"
                                    type="password"
                                    autoComplete="password"
                                    className="account-form_input"
                                />
                            </div>
                        </div>

                        <div className="sm:col-span-4">
                            <label htmlFor="password-confirm" className="account-form_input-label">
                                Confirm Password
                            </label>
                            <div className="mt-2">
                                <input
                                    id="password-confirm"
                                    name="password-confirm"
                                    type="password"
                                    className="account-form_input"
                                />
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <div className="mt-6 flex items-center justify-end gap-x-6">
                <button type="button" className="rounded-md px-3 py-2 text-sm font-semibold leading-6 hover:text-gray-400 shadow-sm">
                    Cancel
                </button>
                <button
                    type="submit"
                    className="rounded-md bg-indigo-600 px-3 py-2 text-sm font-semibold text-white shadow-sm hover:bg-indigo-500 focus-visible:outline focus-visible:outline-2 focus-visible:outline-offset-2 focus-visible:outline-indigo-600">
                    Save
                </button>
            </div>
        </form>
    )
}
