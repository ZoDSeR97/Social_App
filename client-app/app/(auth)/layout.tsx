﻿import React from "react";
import { ClerkProvider } from "@clerk/nextjs";
import { Inter } from "next/font/google";
import "../globals.css";

export const metadata = {
    title: 'Next.js 13 with Clerk',
    description: 'Next app with Clerk authentication',
}

// using next google font
const inter = Inter({subsets: ["latin"]})

export default function RootLayout({
    children
}: {
    children: React.ReactNode
}) {
    return (
        <ClerkProvider>
            <html lang='en'>
                <body className={`${inter.className}`}>
                    { children }
                </body>
            </html>
        </ClerkProvider>
    )
}