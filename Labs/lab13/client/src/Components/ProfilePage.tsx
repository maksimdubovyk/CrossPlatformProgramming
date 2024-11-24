import React, { useEffect, useState } from "react";
import axios from "axios";

interface UserProfile {
    userId: string;
    email: string;
    name: string;
    user_metadata: Record<string, any>;
}

const ProfilePage: React.FC<{ userId: string }> = ({ userId }) => {
    const [userProfile, setUserProfile] = useState<UserProfile | null>(null);

    useEffect(() => {
        const fetchUserProfile = async () => {
            try {
                const response = await axios.get(`/api/user/${userId}`);
                setUserProfile(response.data);
            } catch (error) {
                console.error("Error fetching user profile:", error);
            }
        };

        fetchUserProfile();
    }, [userId]);

    if (!userProfile) {
        return <div>Loading...</div>;
    }

    return (
        <div>
            <h1>User Profile</h1>
            <p>
                <strong>Name:</strong> {userProfile.name}
            </p>
            <p>
                <strong>Email:</strong> {userProfile.email}
            </p>
            <p>
                <strong>Metadata:</strong> {JSON.stringify(userProfile.user_metadata)}
            </p>
        </div>
    );
};

export default ProfilePage;
